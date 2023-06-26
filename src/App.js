import logo from './logo.svg';
import * as React from "react";
import * as ReactDOM from "react-dom/client";
import {
  createBrowserRouter,
  RouterProvider,
}
  from "react-router-dom";
import './App.css';
import Mainpage from './html/mainpage'

const router = createBrowserRouter([
  {
    path: "/",
    element: <Mainpage />,
  },
]);


function App() {
  return (
    <React.StrictMode>
      <RouterProvider router={router} />
    </React.StrictMode>
  );
}

export default App;
