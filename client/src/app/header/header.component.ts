import {Component, Inject, OnInit, Renderer2} from '@angular/core';
import {DOCUMENT} from "@angular/common";

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  theme: any = localStorage.getItem('theme')

  constructor(@Inject(DOCUMENT)
              private document: Document,
              private renderer: Renderer2) {
  }

  ngOnInit(): void {
    this.initTheme()
  }

  initTheme(): void {
    this.renderer.addClass(this.document.body, this.theme)
    localStorage.setItem('theme', this.theme)
  }

  switchTheme() {
    this.document.body.classList.replace(this.theme,
      this.theme === 'light-theme' ? (this.theme = 'dark-theme') : (this.theme = "light-theme"))
    localStorage.setItem('theme', this.theme)
  }
}
