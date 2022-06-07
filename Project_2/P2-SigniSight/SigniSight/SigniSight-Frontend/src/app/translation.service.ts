import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable, throwError, catchError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TranslationService {

  text:string = "";

  //?textToTranslate=hi&endLanguageCode=ru
  translation(textToTranslate:string, endLanguageCode:string):Observable<any>{
    return this.http.post("https://signisight.azurewebsites.net/Translate?textToTranslate=" + textToTranslate +
    "&endLanguageCode="+ endLanguageCode, JSON.stringify({textToTranslate, endLanguageCode}),
    // We need to add headers to specify content type
    //{headers: {'Content-Type':'text/plain'}}
    )
    .pipe(
      catchError((e) =>{
        return throwError(e)
      }
     
    ))
  }
  recognition(imageUrl:string):Observable<any>{
    return this.http.post("https://signisight.azurewebsites.net/OCR?imageUrl=" + imageUrl,imageUrl,
    // We need to add headers to specify content type
    //{headers: {'Content-Type':'text/plain'}}
    {responseType: 'text'})
    .pipe(
      catchError((e) =>{
        return throwError(e)
      }
    ))
  }

  constructor(private http:HttpClient) { }
}