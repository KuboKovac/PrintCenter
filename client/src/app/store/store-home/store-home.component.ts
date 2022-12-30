import {Component} from '@angular/core';
import {FlatTreeControl} from "@angular/cdk/tree";
import {MatTreeFlatDataSource, MatTreeFlattener} from "@angular/material/tree";

@Component({
  selector: 'app-store-home',
  templateUrl: './store-home.component.html',
  styleUrls: ['./store-home.component.scss']
})
export class StoreHomeComponent {
  constructor(){
    this.dataSource.data = NAV_CONTENT_MOCK
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
  dataSource = new MatTreeFlatDataSource(this.treeControl,this.treeFlattener)
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
