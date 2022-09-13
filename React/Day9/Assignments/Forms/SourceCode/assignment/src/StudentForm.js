import react, {useState} from 'react';
const StudentForm=()=>{
    const [values, setvalue]=  useState({stdname: " ", state:" ", gender: " ", city: " ", hobby: " " })
    const [studata, setstudata] = useState([])
    const handleChange =e=> {
        const name= e.target.name;
        const value= e.target.value;
         setvalue((prevState) => {
          return {...prevState, [name]: value}
           
       });
     };
     const handleSubmit =(event) =>{
        setstudata([...studata, values]);
        event.preventDefault();
        console.log(studata);
      }
      return(
          <div className="card p-3">
              <form className="card-body m-auto">
                 <div className="m-2"> <label>Student Name</label><input type="text" name="stdname" value={values.stdname} onChange={handleChange}></input></div>
                 <div className="m-2"> <label>Student City</label><input type="text" name="city" value={values.city} onChange={handleChange}></input></div>
                 <div className="m-2"> <label>Student State</label><input type="text" name="state" value={values.state} onChange={handleChange}></input> </div>
                 <div className="m-2"> <input type="radio" name="gender" value="male" onChange={handleChange} ></input>
                 <label className="p-3">Male</label>
                 <input type="radio"name="gender"  value="female"onChange={handleChange}></input>
                 <label className="p-3">Female</label>
                <input type="radio"  name="gender"  value= "other" onChange={handleChange}></input>
                <label className="p-3">Other</label>
                </div>
                <div className="m-2">
                <label>Hobbies</label>
              <select name="hobby" value={values.hobby} onChange={handleChange}>
                <option>Select Your Hobby</option>
                <option value="Dancing">Dancing </option>
                <option value="Reading">Reading</option>
                <option value="Singing">Singing</option>
                <option value="Cooking">Cooking</option>
                <option value="Painting">Painting</option>
                <option value="Gaming">Gaming</option>
              </select>
              </div>
              <div className="m-2">
              <button type="button" onClick={handleSubmit} className='text-white btn btn-dark'>Submit</button>
              </div>
              </form>
          </div>
      )
}
export default StudentForm