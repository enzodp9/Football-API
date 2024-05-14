import React, { Component } from 'react';

export class TablaResultado extends Component {

    constructor(props) {
        super(props);
        this.state = {
            league: 'La Liga'
        };
    }
    async getData() {
        const response = await fetch('leagues');
        const data = await response.json();
        console.log(data);
        this.setState({ league: data[0].name, loading: false });
    }

    componentDidMount() {
        this.getData();
    }

    render() {
        return (
            <div>
                <h1>Tabla de Resultados</h1>

                <table class="table table-bordered">
                    <thead>
                        <tr class="table-dark">
                            <th colspan="7">{this.state.league}</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td colspan="1">Hora</td>
                            <td colspan="2">Equipo1</td>
                            <td colspan="1">0</td>
                            <td colspan="1">0</td>
                            <td colspan="2">Equipo2</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        );
    }
}
