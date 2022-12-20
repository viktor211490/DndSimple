import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dnd',
  templateUrl: './dnd.component.html',
  styleUrls: ['./dnd.component.scss']
})
export class DndComponent implements OnInit {
  show = false;
  title = 'dnd-front';
  constructor() { }

  ngOnInit(): void {
  }

}
