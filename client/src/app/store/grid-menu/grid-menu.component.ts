import {Component, OnInit} from '@angular/core';
import {StoreService} from "../services/store.service";

@Component({
  selector: 'app-grid-menu',
  templateUrl: './grid-menu.component.html',
  styleUrls: ['./grid-menu.component.scss']
})
export class GridMenuComponent implements OnInit {

  public categories: string[] = []

  constructor(
    private storeService: StoreService
  ) {
  }

  ngOnInit(): void {
    this.storeService.getCategories().subscribe(response => {
      this.categories = response.map(cat => cat.name)
    })
  }
}
