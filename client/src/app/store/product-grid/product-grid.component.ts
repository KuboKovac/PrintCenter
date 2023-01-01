import {ChangeDetectionStrategy, Component, OnInit} from '@angular/core';
import {ActivatedRoute} from "@angular/router";

@Component({
  selector: 'app-product-grid',
  templateUrl: './product-grid.component.html',
  styleUrls: ['./product-grid.component.scss'],
})
export class ProductGridComponent implements OnInit {

  gridId : string | null = ''
  constructor(
    private activatedRoute:ActivatedRoute
  )
  {}

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe(params => {
      this.gridId = this.activatedRoute.snapshot.paramMap.get('id')
    })
  }

}
