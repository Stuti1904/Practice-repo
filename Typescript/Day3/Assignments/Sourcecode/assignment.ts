import { SelectedPerson } from "./selected";
import { Applicant,applicantStack } from "./applicant";
import { Interview } from "./interview";
import { Vacancy } from "./vacancy";
import { Person } from "./person";


var applicant1 = new Applicant();
applicant1.createApplicant({ id: 1, name: "Stuti", email: "abc@cde.com", mobNo: 9106754761, address: "HELLO", experience: 0.5 })
applicant1.createApplicant({ id: 2, name: "Hritika", email: "cde@gf.com", mobNo: 8160672563, address: "HI", experience: 0.4 })
console.log('----------------------------------------------------');

applicant1.viewAllApplicant();
console.log('----------------------------------------------------');

applicant1.viewByIdApplicant(1);
console.log('----------------------------------------------------');

var vac1 = new Vacancy();
vac1.createVacancy({
    id: 1,
    post: 'DotnetDeveloper',
    vacNo: 33,
    company_Name: 'Radixweb1',
    jobDes: 'JOB IN DOTNET'
});
vac1.createVacancy({
    id: 2,
    post: 'PHPDeveloper',
    vacNo: 33,
    company_Name: 'onlinephp.com',
    jobDes: 'PHP JOB'
});
vac1.createVacancy({
    id: 3,
    post: 'NodeDeveloper',
    vacNo: 69,
    company_Name: 'google',
    jobDes: 'NODE JOB'
});
console.log('----------------------------------------------------');

vac1.displayAllVacancy();
console.log('----------------------------------------------------');

vac1.viewOneVacancy(1);
console.log('----------------------------------------------------');
var interview1 = new Interview()
interview1.scheduleInterview({
    id: 1,
    date: '22/2/2023',
    type: 'walk in',
    appliId: 1,
    vacId: 1
});
interview1.scheduleInterview({
    id: 2,
    date: '22/2/2023',
    type: 'campus-placement',
    appliId: 2,
    vacId: 2
});
interview1.scheduleInterview({
    id: 3,
    date: '22/2/2023',
    type: 'campus-placement',
    appliId: 3,
    vacId: 3
});

console.log('----------------------------------------------------');

interview1.viewAllInterview();
console.log('----------------------------------------------------');

interview1.updateInterview(2,true);
interview1.updateInterview(3,true);
console.log('----------------------------------------------------');

interview1.hiredPep();