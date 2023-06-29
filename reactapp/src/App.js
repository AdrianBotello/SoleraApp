//import tailwind
import './App.css';
import * as React from "react";
//router import
import {
    createBrowserRouter,
    RouterProvider,
}
    from "react-router-dom";
//import others html pages
import Mainpage from './html/mainpage'

//this part is necessary to make the router, to be able to access any page
const router = createBrowserRouter([
    {
        //default page
        path: "/",
        element: <Mainpage />,
    },
]);

//in this part add the router
function App() {
    return (
        <React.StrictMode>
            <RouterProvider router={router} />
        </React.StrictMode>
    );
}

export default App;
