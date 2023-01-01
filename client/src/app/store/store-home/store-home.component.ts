import {ChangeDetectionStrategy, Component, OnInit} from '@angular/core';
import {FlatTreeControl} from "@angular/cdk/tree";
import {MatTreeFlatDataSource, MatTreeFlattener} from "@angular/material/tree";
import {StoreService} from "../store.service";
import {ICategory} from "../models/ICategory";
import {IBrand} from "../models/IBrand";
import {Router} from "@angular/router";

@Component({
  selector: 'app-store-home',
  templateUrl: './store-home.component.html',
  styleUrls: ['./store-home.component.scss'],
})
export class StoreHomeComponent implements OnInit {

  categories: ICategory[] = []
  brands: IBrand[] = []
  dropdownData: NavContent[] = []

  constructor(
    private storeService: StoreService,
    private router: Router
  ) {
  }

  ngOnInit(): void {
    //Sorry I know... unfortunately I couldn't find any better solution
    //TODO - Create normal code
    new Promise((resolve) => {
      setTimeout(resolve, 300)
    }).then(() => {
      this.getBrands()
      this.getCategories()
      new Promise((resolve) => {
        setTimeout(resolve,450)
      }).then(() => {
        this.populateDropdown(this.categories, this.brands)
        this.dataSource.data = this.dropdownData
      })
    })
  }
  /*
  ___________________________
    DROPDOWN BULLSHIT CODE
  ___________________________
   */
  private getBrands() {
    this.storeService.getBrands().subscribe(response => {
      this.brands = response as IBrand[]
    })
  }

  private getCategories() {
    this.storeService.getCategories().subscribe(response => {
      this.categories = response as ICategory[]
    })
  }

  private populateDropdown(categories: ICategory[], brands: IBrand[]) {
    const categoryNames: NavContent[] = categories.map(cat => {
      return {name: cat.name}
    })
    const brandNames: NavContent[] = brands.map(brnd => {
      return {name: brnd.name}
    })
    const navData: NavContent[] = [
      {
        name: 'ALL PRODUCTS'
      },
      {
        name: 'CATEGORIES',
        child: categoryNames
      },
      {
        name: 'BRANDS',
        child: brandNames
      },
    ]
    this.dropdownData = navData
  }

  private _transformer = (node: NavContent, level: number) => {
    return {
      expandable: !!node.child && node.child.length > 0,
      name: node.name,
      level: level
    }
  }
  treeControl = new FlatTreeControl<ExampleFlatNode>(
    node => node.level,
    node => node.expandable
  )

  treeFlattener = new MatTreeFlattener(
    this._transformer,
    node => node.level,
    node => node.expandable,
    node => node.child
  )
  dataSource = new MatTreeFlatDataSource(this.treeControl, this.treeFlattener)
  hasChild = (_: number, node: ExampleFlatNode) => node.expandable;


}

interface NavContent {
  name: string,
  child?: NavContent[]
}

interface ExampleFlatNode {
  expandable: boolean;
  name: string;
  level: number;
}

const NAV_CONTENT_MOCK: NavContent[] = [
  {
    name: "CATEGORIES",
    child: [{name: "Printers"}, {name: "Filaments"}, {name: "Resins"}, {name: "Parts"}]
  },
  {
    name: "BRANDS",
    child: [{name: "Creality"}, {name: "Anycubic"}, {name: "Prusa"}, {name: "Ultimaker"}]
  }
]
