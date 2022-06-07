import { Component, OnInit } from '@angular/core';
import { OcrService } from '../ocr.service';
import { Router } from '@angular/router';

@Component({
  selector: 'ocr',
  templateUrl: './ocr.component.html',
  styleUrls: ['./ocr.component.css']
})
export class OcrComponent implements OnInit {

  imageUrl:string = "";
  error:boolean = false;

  onSubmit():void{
    this.ocrService.recognition(this.imageUrl)
    .subscribe((data) =>{
      console.log(data)
      // If we successfully login, let's redirect to the home page
      //this.router.navigate(['home'])
    },
    (error) =>{
      console.log(error)
      // Makes error message appear through ngIf
      this.error = true;
    })
    //return this.translationService.text;
  }
  //Inject login service to component to use methods
  // Inject router for navigation
  constructor(private ocrService:OcrService, private router:Router) { }

  ngOnInit(): void {
  }

}
