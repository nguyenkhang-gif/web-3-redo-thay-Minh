import { Component, OnInit } from "@angular/core";
import { SachService } from "../../services/sach.service";
import { Todo } from "../../models/Todo";
@Component({
    selector: 'app-home',
    templateUrl: 'home.component.html',
    styleUrls: ['home.component.scss']
})
export class HomeComponent implements OnInit {
    products: Todo[];
    constructor(
        private service: SachService
    ) { }
    ngOnInit(): void {
        this.service.getBooks().subscribe({
            next: (todos) => {
                this.products = todos;
            }
        })
    }

}