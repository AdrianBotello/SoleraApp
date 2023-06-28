import React, { Component, useEffect, useState } from 'react';

const App = () => {

    const [state, setState] = useState("");

    useEffect(() => {
        fetch('api/GetHello').then(res => res.json()).then(data => setState(data))
    }, [])

    return (
        <div>
            <h1 id="tabelLabel" >Weather forecast</h1>
            <h2 id="tabelLabel" >{ JSON.stringify(state) }</h2>
             <p>This component demonstrates fetching data from the server.</p>
           </div>
    )
}

export default App;

//export default class App extends Component {
//    static displayName = App.name;

//    componentDidMount() {
//        this.fetchData();
//    }

//    render() {
//        /*let contents = this.state.loading
//            ? <p><em>Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationreact">https://aka.ms/jspsintegrationreact</a> for more details.</em></p>
//            : App.renderForecastsTable(this.state.forecasts);*/

//        return (
//            <div>
//                <h1 id="tabelLabel" >Weather forecast</h1>
//                <p>This component demonstrates fetching data from the server.</p>
//            </div>
//        );
//    }

//    async fetchData() {
//        const response = await fetch('https://localhost:7191/REST');
//        console.log(response)
//        const data = await response.text();
//    }
//}
