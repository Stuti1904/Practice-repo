import react, {useState} from 'react';
function Trial() {
    const [state, setState] = useState({
      gender: false,
      love: false
    });
    const handleToggle = ({ target }) =>{
      setState(s => ({ ...s, [target.name]: !s[target.name] }));
      console.log(state)
    }
  
    return (
      <div>
        {Object.keys(state).map(key => (
          <input
            type="checkbox"
            onChange={handleToggle}
            key={key}
            name={key}
            checked={state[key]}
          />
        ))}
      </div>
    );
  }
  export default Trial