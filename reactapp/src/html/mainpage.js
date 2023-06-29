import React, { useEffect, useState } from 'react';
import LogoSolera from '../img/solera_holdings_inc_logo.jpg';

// Importar los datos desde json
import data from './json/data.json';

function MainPage() {
    const [selectedTeam, setSelectedTeam] = useState(null);
    const [groups, setGroups] = useState(null);

    useEffect(() => {
        setGroups(data);
    }, []);

    const handleTeamClick = (teamId) => {
        setSelectedTeam(teamId);
    };

    const handleGoBack = () => {
        setSelectedTeam(null);
    };

    if (!groups) {
        return <div>Cargando...</div>;
    }

    return (< div className = "container mx-auto px-4" >
            {/*first page*/ }

            <header className="flex items-center justify-between py-4">
                <div className="flex items-center">
                    <img className="w-32 h-auto" src={LogoSolera} alt="Logo_Solera" />
                    <h1 className="ml-4 text-xl font-bold">Aplicacion Solera</h1>
                </div>
            </header>
            <div className="grid grid-cols-2 gap-4 mt-8">
            
                {groups.map((group) => (
                    <div
                        key={group._id.$oid}
                        className="w-full h-32 bg-gray-300 rounded-md flex flex-col justify-center items-center cursor-pointer"
                        onClick={() => handleTeamClick(group._id.$oid)}
                    >
                        <h2 className="text-lg font-bold mb-2">{group.group_name}</h2>
                        <p className="text-2xl">{group.total_score}</p>
                    </div>
                ))}
            </div>

            {/*second page*/}
            {selectedTeam && (
                <div className="absolute top-0 left-0 w-full h-full bg-white">
                    <button className="absolute top-0 left-0 m-4 bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded" onClick={handleGoBack}>
                        Volver
                    </button>
                    <div className="text-center mt-8">
                        <h2 className="text-lg font-bold mb-2">
                            {groups.find((group) => group._id.$oid === selectedTeam).group_name}
                        </h2>
                        <p className="text-2xl">
                            Total Score: {groups.find((group) => group._id.$oid === selectedTeam).total_score}
                        </p>
                    </div>
                    <div className="mt-8 mx-4">
                        <div className="grid grid-cols-2 gap-4">
                            <div className="text-left">
                                <h3 className="text-lg font-bold mb-4">Proyecto</h3>
                                {groups.find((group) => group._id.$oid === selectedTeam).projects.map((project) => (
                                    <p key={project.project_name}>{project.project_name}</p>
                                ))}
                            </div>
                            <div className="text-right">
                                <h3 className="text-lg font-bold mb-4">Score</h3>
                                {groups.find((group) => group._id.$oid === selectedTeam).projects.map((project) => (
                                    <p key={project.project_name}>{project.score}</p>
                                ))}
                            </div>
                        </div>
                    </div>
                </div>
            )}
        </div>
    );
}

export default MainPage;

