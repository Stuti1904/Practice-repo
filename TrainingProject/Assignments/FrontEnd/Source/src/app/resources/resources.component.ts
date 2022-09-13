import { Component, OnInit } from '@angular/core';
import { adminUser } from 'Models/adminUser';
import { AdminUserServiceService } from '../admin-user-service.service';
import { resources } from 'Models/resources';
import { ResourceService } from '../resource.service';
import { FormBuilder } from '@angular/forms';
import { MatDialogRef, MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-resources',
  templateUrl: './resources.component.html',
  styleUrls: ['./resources.component.css']
})
export class ResourcesComponent implements OnInit {
  resource: Array<resources>=[];
  Resource:Array<resources>=[];
  res:any;
  deleted:any;
   d:any= new Date(Date.now());
   now:any = this.d.toISOString();
  constructor(private fb:FormBuilder,
    private service: ResourceService,) { }
    AddResource=this.fb.group({
      url:[''],
      createddate:[this.now],
      createdby:[2],
      isActive: [true]
    });
  ngOnInit(): void {
    this.service.get().subscribe((resource: Array<resources>)=>{
      this.Resource=resource;
    })
  }
  update(id:number){
    this.res=this.AddResource.value;
    this.service.put(this.res,id).subscribe((a:resources)=>{
      this.res=a;

    })

    this.AddResource.reset();
  }
  delete(id:number){
    this.service.delete(id).subscribe((a:any)=>{ this.deleted=a});
    this.ngOnInit();
  }
}
