import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";

@Component({
  selector: "navbar",
  templateUrl: "./navbar.component.html",
  styleUrls: ["./navbar.component.css"],
})
export class NavbarComponent implements OnInit {
  navigateTranslator() {
    this.router.navigate(["translation"]);
  }

  constructor(private router: Router) {
    console.log("constructor initialized");
  }

  isDarkMode = false;

  toggleSwitch() {
    this.isDarkMode = !this.isDarkMode;
  }

  ngOnInit(): void {}
}
