import React, { useState, useEffect } from "react";
import Footer from "../Components/layout/Footer";
import NavBar from "../Components/layout/NavBar";
import axios from "axios";
import Mesazhi from "../Components/layout/Mesazhi";
import "./Styles/ContactUs.css";
import { Helmet } from "react-helmet";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faEnvelopeCircleCheck } from "@fortawesome/free-solid-svg-icons";
import Form from "react-bootstrap/Form";
import FloatingLabel from 'react-bootstrap/FloatingLabel';
import Button from "react-bootstrap/esm/Button";



const ContactUs = () => {
  const [emri, setEmri] = useState("");
  const [email, setEmail] = useState("");
  const [msg, setMsg] = useState("");
  const [shfaqMesazhin, setShfaqMesazhin] = useState(false);
  const [tipiMesazhit, setTipiMesazhit] = useState("");
  const [pershkrimiMesazhit, setPershkrimiMesazhit] = useState("");
  const [user, setUser] = useState([]);
  const [perditeso, setPerditeso] = useState("");

  const getID = localStorage.getItem("id");

  const getToken = localStorage.getItem("token");

  const authentikimi = {
    headers: {
      Authorization: `Bearer ${getToken}`,
    },
  };

  useEffect(() => {
    if (getID) {
      const vendosTeDhenat = async () => {
        try {
          const teDhenat = await axios.get(
            `https://localhost:7156/api/Perdoruesi/shfaqSipasID?idUserAspNet=${getID}`, authentikimi
          );

          setUser(teDhenat.data)



        } catch (err) {
          console.log(err);
        };
      }
      vendosTeDhenat();
    }
  }, [perditeso]);

  function vendosEmrin(value) {
    setEmri(value);
  }

  function vendosEmail(value) {
    setEmail(value);
  }

  function vendosMesazhin(value) {
    setMsg(value);
  }

  function dergoMesazhin() {
    axios.post("https://localhost:7156/api/ContactForm/shtoMesazhin", {
      mesazhi: msg,
      emri: emri,
      email: email,
      userId: getID ? user.perdoruesi.userId : null
    }, authentikimi)
      .then((response) => {
        
        setTipiMesazhit("success");
        setPershkrimiMesazhit("Mesazhi u Dergua me Sukses!")
        setShfaqMesazhin(true);
        setEmri("");
        setEmail("");
        setMsg("");
      })
      .catch((error) => {
        console.log(error);
        setTipiMesazhit("danger");
        setPershkrimiMesazhit("Na vjen keq! Mesazhi nuk u dergua, Ju lutemi provoni me vone")
        setShfaqMesazhin(true);
      });
  }

  return (
    <div className="body">
      <Helmet>
        <title>Contact Us | ManU Store</title>
      </Helmet>
      <NavBar />
      {shfaqMesazhin && <Mesazhi
        tipi={tipiMesazhit}
        pershkrimi={pershkrimiMesazhit}
        setShfaqMesazhin={setShfaqMesazhin}
      />}
      <div className="forms">
        <Form className="form">
          <Form.Text className="formTitle">Contact Us</Form.Text>
          <FloatingLabel

            controlId="floatingInput"
            label="Emri"
            className="mb-3"
          >
            <Form.Control className="inputt"
              value={emri}
              placeholder="Email"
              type="text"
              onChange={(e) => vendosEmrin(e.target.value)} />
          </FloatingLabel>
          <FloatingLabel
            controlId="floatingInput"
            label="Email"
            className="mb-3"
          >
            <Form.Control className="inputt"
              value={email}
              type="text"
              placeholder="Email"
              onChange={(e) => vendosEmail(e.target.value)} />
          </FloatingLabel>
          <FloatingLabel
            controlId="floatingInput"
            label="Mesazhi Juaj"
          >
            <Form.Control className="inputt"
              value={msg}
              as="textarea"
              style={{ height: '150px' }}
              placeholder="Mesazhi Juaj"
              onChange={(e) => vendosMesazhin(e.target.value)} />
          </FloatingLabel>
          <Button
            className="button"
            onClick={dergoMesazhin}
          >
            Send <FontAwesomeIcon icon={faEnvelopeCircleCheck} />
          </Button>
        </Form>
      </div>
      <Footer />
    </div>
  )
}
export default ContactUs;
