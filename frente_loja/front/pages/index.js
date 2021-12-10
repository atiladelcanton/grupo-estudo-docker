import { useEffect } from "react";
import styles from "../styles/Home.module.css";

export default function Home() {
  useEffect(() => {
    const getVersion = async () => {
      await fetch("http://clients.frenteloja.local/api/version")
        .then((res) => res.json())
        .then((data) => console.log("FOI ", data));
    };
    getVersion();
  }, []);
  return <div className={styles.container}></div>;
}
