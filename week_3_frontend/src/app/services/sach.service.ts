import { HttpClient, HttpHeaders } from '@angular/common/http'
import { Injectable } from '@angular/core';
import { Todo } from '../models/Todo';

@Injectable({ providedIn: 'root' })
export class SachService {

    constructor(
        private httpClient: HttpClient
    ) { }

    getBooks() {
         return this.httpClient.get<Todo[]>("https://jsonplaceholder.typicode.com/todos");
    }

    insertProduct(todo: Todo) {

        return this.httpClient.post<Todo>("https://endpoint", todo,)
    }

    updateProduct(todo: Todo) {
        return this.httpClient.put<Todo>("https://endpoint", todo, {})
    }

    deleteProduct(id: number) {
        return this.httpClient.delete<Todo>("https://endpoint/" + id, {})
    }
}