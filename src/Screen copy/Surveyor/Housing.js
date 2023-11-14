import React, { useState } from "react";
import BottomNavigation from "../BottomNavigation";
import Title from "../../CommonComponent/Title";
import Questiones from "../../CommonComponent/Questiones";
import housing from "../../Questions/Housing";
import { useNavigate } from "react-router-dom";
import { NavbarTitle } from "../../CommonComponent/NavbarTitle";
function Housing() {
  const [responseBody, setresponseBody] = useState({});
  const navigate = useNavigate();

  function inputChangeHandler(event) {
    const { name, value } = event.target;
    setresponseBody({ ...responseBody, [name]: value });
  }

  function onSubmitHandler() {
    console.log("Submitted Successfully");
    console.log(responseBody);
    navigate("/Surveyor/SurveyDetails");
  }

  function backNavigator() {
    navigate("/Surveyor/SurveyDetails");
  }

  return (
    <>
    <NavbarTitle data={{ Title: "Housing Details" }}></NavbarTitle>
      <div className="container">
      
        <div className="container d-flex mx-auto justify-content-center">
          <h5 className="m-3">Surveyor Id :C202201103</h5>
          <h5 className="m-3">Surveyor Name : Pradeep</h5>
        </div>
        
        <Questiones
          api={housing.Questions}
          inputChangeHandler={inputChangeHandler}
        />
        <BottomNavigation
          onSubmitHandler={onSubmitHandler}
          backNavigator={backNavigator}
        />
      </div>
    </>
  );
}

export default Housing;
