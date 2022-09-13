import React, { useState } from 'react'

const ComponentCalc = () => {
    const [num1, setNum1] = useState(0)
    const [num2, setNum2] = useState(0)
    const [result, setResult] = useState("")
    const [operator, setOperator] = useState()
    const Calculate = () => {
        if (operator) {
            switch (operator) {
                case "add":
                    setResult(num1 + num2);
                    break;
                case "sub":
                    setResult(num1 - num2);
                    break;
                case "multiply":
                    setResult(num1 * num2);
                    break;
                case "divide":
                    setResult(num1 / num2);
                    break;
            }
        } else {
            setResult("Error");
        }
    }
    return (
        <div class="container bg-secondary d-flex justify-content-center mt-5">
            <div class="">
                <form class="d-flex flex-column align-items-center py-5">
                    <div>
                        <label class="form-label text-black" for="number1"
                        >Enter Number 1:
                        </label>
                        <input
                            class="form-control"
                            type="number"
                            value={num1}
                            onChange={(e) => setNum1(parseInt(e.target.value))}
                            id="number1"
                        /><br/>
                    </div>
                    <div class="my-3">
                        <label class="form-label text-black" for="number2"
                        >Enter Number 2:
                        </label>
                        <input
                            class="form-control"
                            type="number"
                            value={num2}
                            onChange={(e) => setNum2(parseInt(e.target.value))}
                            id="number2"
                        />
                    </div>
                    <div class="d-flex gap-2">
                        <div class="form-check">
                            <input
                                class="form-check-input"
                                type="radio"
                                name="flexRadioDefault"
                                id="flexRadioDefault1"
                                value="add"
                                onClick={(e) => setOperator(e.target.value)}
                            />
                            <label class="form-check-label text-black" for="flexRadioDefault1">
                                Add
                            </label>
                        </div><br/>
                        <div class="form-check">
                            <input
                                class="form-check-input"
                                type="radio"
                                name="flexRadioDefault"
                                id="flexRadioDefault2"
                                value="sub"
                                onClick={(e) => setOperator(e.target.value)}
                            />
                            <label class="form-check-label text-black" for="flexRadioDefault2">
                                Sub
                            </label>
                        </div><br/>
                        <div class="form-check">
                            <input
                                class="form-check-input"
                                type="radio"
                                name="flexRadioDefault"
                                id="flexRadioDefault3"
                                value="multiply"
                                onClick={(e) => setOperator(e.target.value)}
                            />
                            <label class="form-check-label text-black" for="flexRadioDefault3">
                                Multiply
                            </label>
                        </div><br/>
                        <div class="form-check">
                            <input
                                class="form-check-input"
                                type="radio"
                                name="flexRadioDefault"
                                id="flexRadioDefault4"
                                value="divide"
                                onClick={(e) => setOperator(e.target.value)}
                            />
                            <label class="form-check-label text-black" for="flexRadioDefault4">
                                Divide
                            </label>
                        </div><br/>
                    </div>
                    <button
                        class="btn btn-outline-light mt-3"
                        type="button"
                        onClick={Calculate}
                    >
                        Calculate
                    </button>
                    {
                         (result === "Error" ? <label class="text-danger fs-3 mt-3"
                        >Error
                            <span class="text-black"> Please choose an operator</span></label> :
                            <label class="text-dark fs-3 mt-3"
                            >result is {result}</label>
                        )}

                </form>
            </div>
        </div>
    )
}

export default ComponentCalc