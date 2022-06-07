import { Component, OnInit } from "@angular/core";
import { Router } from '@angular/router';
import { TranslationService } from '../translation.service';

@Component({
  selector: "translation",
  templateUrl: "./translation.component.html",
  styleUrls: ["./translation.component.css"]
})
export class TranslationComponent implements OnInit {

  textToTranslate:string = "";
  endLanguageCode:string = "";
  error:boolean = false;
  translatedText:string = "";
  

  translate():void{
    this.translationService.translation(this.textToTranslate, this.endLanguageCode)
    .subscribe((data) =>{
      console.log(data[0].translations[0].text)
      this.translatedText = data[0].translations[0].text
    },
    (error) =>{
      console.log(error)
      // Makes error message appear through ngIf
      this.error = true;
    })
  }

  imageUrl:string = "";
  imageText:string = "";
  ocr():void{
    this.translationService.recognition(this.imageUrl)
    .subscribe((data) =>{
      console.log(data)
      this.imageText = data
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

  constructor(private translationService:TranslationService, private router:Router) { }
  ngOnInit(): void {
  }

  // url="";
  
  // onInputURL(e){
  //   if(e.target.files){
  //     var reader = new FileReader();
  //     reader.readAsDataURL(e.target.files[0]);
  //     reader.onload=(event:any)=>{
  //       this.url=event.target.result;
  //     }
  //   }
  // }
}
