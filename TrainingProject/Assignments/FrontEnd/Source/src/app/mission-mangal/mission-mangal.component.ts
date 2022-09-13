import { Component, OnInit } from '@angular/core';
import { generalInfo } from 'Models/generalInfo';
import { DetailsService } from '../details.service';

@Component({
  selector: 'app-mission-mangal',
  templateUrl: './mission-mangal.component.html',
  styleUrls: ['./mission-mangal.component.css']
})
export class MissionMangalComponent implements OnInit {

  Info: Array<generalInfo> = [];

  constructor(private service:DetailsService) { }

  ngOnInit(): void {

    this.service.getdetails().subscribe((info: Array<generalInfo>)=>{
        this.Info=info;
    })
  }

}
