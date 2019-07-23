import * as React from 'react';
import Head from 'next/head';
import '../styles/index.scss';
import Api from '../api/api';


class Index extends React.Component<any, any> {

    render() {
        return (
            <React.Fragment>
                <Head>
                    <title>Parkner</title>
                </Head>
                <h1>Pendientes</h1>
                <h2><a href="https://github.com/johnnietirado/code-challenges-parkner/tree/solution/front-end" target="_blank">Instrucciones</a></h2>
                <div>¡Usa tu creatividad y muestrame que tan bonito puedes hacer una lista de pendientes!</div>
            </React.Fragment>
        )
    }
}

export default Index;