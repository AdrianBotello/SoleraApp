import LogoSolera from '../img/solera_holdings_inc_logo.jpg'

function App() {
    return (
        <div className="container mx-auto px-4">
            <header className="flex items-center justify-between py-4">
                <img
                    className="w-32 h-auto"
                    src={LogoSolera}
                    alt="Logo_Solera"
                />
            </header>
            <div className="grid grid-cols-2 gap-4 mt-8">
                <div className="w-full h-32 bg-gray-300 rounded-md flex flex-col justify-center items-center">
                    <h2 className="text-lg font-bold mb-2">Equipo 1</h2>
                    <p className="text-2xl">5</p>
                </div>
                <div className="w-full h-32 bg-gray-300 rounded-md flex flex-col justify-center items-center">
                    <h2 className="text-lg font-bold mb-2">Equipo 2</h2>
                    <p className="text-2xl">7</p>
                </div>
                <div className="w-full h-32 bg-gray-300 rounded-md flex flex-col justify-center items-center">
                    <h2 className="text-lg font-bold mb-2">Equipo 3</h2>
                    <p className="text-2xl">3</p>
                </div>
                <div className="w-full h-32 bg-gray-300 rounded-md flex flex-col justify-center items-center">
                    <h2 className="text-lg font-bold mb-2">Equipo 4</h2>
                    <p className="text-2xl">9</p>
                </div>
            </div>

        </div>
    );
}

export default App;