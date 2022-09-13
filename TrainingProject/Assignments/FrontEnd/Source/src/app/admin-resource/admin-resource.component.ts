import { Component, OnInit } from '@angular/core';
import { AngularFirestoreModule } from '@angular/fire/compat/firestore';
import { FormBuilder } from '@angular/forms';
import { ResourceService } from '../resource.service';
import { MatDialogRef, MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-admin-resource',
  templateUrl: './admin-resource.component.html',
  styleUrls: ['./admin-resource.component.css']
})
export class AdminResourceComponent implements OnInit {

  resource:any;
   d:any= new Date(Date.now());
   now:any = this.d.toISOString();
  constructor(private fb:FormBuilder,
    private service: ResourceService,
    public dialogRef: MatDialogRef<AdminResourceComponent>,
    private dialog: MatDialog) { 
     
    }
AddResource=this.fb.group({
  url:[''],
  createddate:[this.now],
  createdby:[2],
  isActive: [true]
});
  ngOnInit(): void {
  }
upload(){
this.resource= this.AddResource.value;
this.resource.createdby= parseInt(this.resource.createdby);
this.resource.isActive=JSON.parse( this.resource.isActive);
this.service.post(this.resource).subscribe((a:any)=>{ this.resource=a});
this.dialogRef.close();
}
}
