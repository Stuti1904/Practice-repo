import { HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { content } from 'Models/content';
import { CrudService } from '../crud.service';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent implements OnInit {

  Content: Array<content> = [];

  constructor(private service: CrudService) { }



  ngOnInit(): void {

    this.service.getContent().subscribe((content: Array<content>) => {

      this.Content = content;

    })
  }
}

