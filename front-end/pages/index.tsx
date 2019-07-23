import * as React from 'react';
import '../styles/index.scss';
import Api from '../api/api';


class Index extends React.Component<any, any> {

    render() {
        return (
            <React.Fragment>
                <h1>To-do</h1>
                <h2><a href="">Instrucciones</a></h2>
                <div>¡Usa tu creatividad y muestrame que tan bonito puedes hacer una lista de pendientes!</div>
            </React.Fragment>
        )
    }
}

export default Index;