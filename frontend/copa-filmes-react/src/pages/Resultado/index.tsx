import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';

import {Finalista, Voltar} from './styles';
import Carregando from '../../components/Carregando';
import Banner from '../../components/Banner';

interface Filme{
  id: string;
  titulo: string;
  ano: number;
  nota: number;
}

interface ResultadoProps {
  location: any;
}

const Resultado: React.FC<ResultadoProps> = ({location}) => {
  const [filmes, setFilmes] = useState<Filme[]>([]);

  useEffect(() => {
    setFilmes(location.state)
  }, []);

  return (
    <>
    <Banner titulo="Campeonato de Filmes" fase="Resultado Final" descricao="Veja o resultado final do campeonado de filmes de forma simples e rápida" />
    { filmes.length == 0 && <Carregando />}
    { filmes.length > 0 &&
      <>
      {filmes.map((filme: Filme) => (
        <Finalista key={filme.id}>
        <div>
          {filme == filmes[0] && <p>1°</p> }
          {filme == filmes[1] && <p>2°</p>}
        </div>
        <div>
          <p>{filme.titulo}</p>
        </div>
        </Finalista>
      ))}
      </>
    }
    <Voltar>
      <Link to='/'>Voltar</Link>
    </Voltar>
    </>
  )
}

export default Resultado;
