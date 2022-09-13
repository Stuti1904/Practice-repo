import react, {useState} from 'react';
const Check=()=>{
    const [values, setvalues] = useState({
        id: "",
        name: "",
        education: "",
      });
      const [student, setstudent] = useState([]);
      const handleChange = (event) => {
        const name = event.target.name;
        const value = event.target.value;
        setvalues((prevState) => {
          return { ...prevState, [name]: value }
        });
      };
    
      const handleSubmit = (event) => {
        event.preventDefault();
        setstudent([...student, values]);
    
      };
      return (
        <div>
          <form onSubmit={handleSubmit} className='row mt-3'>
            <div>
              <label >ID</label>
              <input type="text" name="id" value={values.id} onChange={handleChange} ></input>
            </div>
            <div>
              <label >Name</label>
              <input type="text" name="name" value={values.name} onChange={handleChange} ></input>
            </div>
            <div>
              <label >Education</label>
              <select value={values.education} onChange={handleChange} name="education" >
                <option>Select Education</option>
                <option value="BE">BE</option>
                <option value="ME">ME</option>
                <option value="Btech">Btech</option>
                <option value="Mtech">Mtech</option>
                <option value="BSC">BSC</option>
                <option value="MSC">MSC</option>
              </select>
            </div>
            <div>
              <button type="submit">Submit</button>
            </div>
          </form>
          <div>
            {student.map((stu) => (
              <ul>
                <li>Student ID: {stu.id}</li>
                <li>Student Name: {stu.name}</li>
                <li>Student Education: {stu.education}</li>
              </ul>
            ))}
          </div>
        </div>
      );
}
export default Check