import {Component, OnInit} from '@angular/core';
import {FlatTreeControl} from "@angular/cdk/tree";
import {MatTreeFlatDataSource, MatTreeFlattener} from "@angular/material/tree";
import {StoreService} from "../services/store.service";
import {ICategory} from "../models/ICategory";
import {IBrand} from "../models/IBrand";

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
  ) {
  }

  ngOnInit(): void {
    this.storeService.getCategories().subscribe(cat => {
      this.categories = cat
    })
    this.storeService.getBrands().subscribe(brd => {
      this.brands = brd
    })
    setTimeout(() => {
      this.populateDropdown(this.categories, this.brands)
      this.dataSource.data = this.dropdownData
    }, 600)
  }
  /*
  ___________________________
    DROPDOWN BULLSHIT CODE
  ___________________________
   */
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
