import { Component, OnInit, Input } from '@angular/core';
import { IPerson } from '../IPerson';
@Component({
  selector: 'person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {

  @Input() peep:IPerson = {
    name: "",
    about: "",
    interest: ""
  }
  selected:boolean = false;

  selectPerson():void{
    this.selected = !this.selected;
  }

  constructor() { }

  ngOnInit(): void {
  }

}
