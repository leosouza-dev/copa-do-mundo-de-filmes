import React, { useState, useEffect, FormEvent} from 'react';
import { useHistory } from 'react-router-dom';

import api from '../../services/api';
import {Erro, Filmes, DivControle} from './styles';
import Carregando from '../../components/Carregando';
import Banner from '../../components/Banner';


interface Filme{
  id: string;
  titulo: string;
  ano: number;
  nota: number;
}

const ListagemFilmes = () => {

  const history = useHistory();

  const [filmes, setFilmes] = useState<Filme[]>([]);
  const [filmesSelecionados, setFilmesSelecionados] = useState<string[]>([]);
  const [totalFilmesSelecionados, setTotalFilmesSelecionados] = useState(0)
  const [filmesOk, setFilmesOk] = useState<Filme[]>([]);
  const [erro, setErro] = useState('');

  // listando todos os filmes
  useEffect(() => {
    api.get(``).then(response => {
      setFilmes(response.data);
    });
  }, [])

  // listando os filmes que o usuário seleciona (convertendo) -> array de Filme
  useEffect(() => {
    setFilmesOk(
      filmes.filter(filme => {
        return (filmesSelecionados.find(f => f == filme.id))
      })
    )
  }, [totalFilmesSelecionados])

  // selecionando os filmes (array de string)
  function handleSelecionaFilme(event: React.ChangeEvent<HTMLInputElement>){
    const filme = event.target.value
    if(event.target.checked){
      setFilmesSelecionados([...filmesSelecionados, filme])
      setTotalFilmesSelecionados(totalFilmesSelecionados + 1);
    }

    if(!event.target.checked){
      const index = filmesSelecionados.indexOf(filme)
      const arrayAux = filmesSelecionados;
      arrayAux.splice(index, 1);
      setFilmesSelecionados(arrayAux)
      setTotalFilmesSelecionados(totalFilmesSelecionados - 1);
    }
  }

  function exibeErro(error: any)
  {
    setErro(error.mensagem);
  }

  // envia os filmes para o campeonato
  async function handleGeraCampeonato(){
    await api.post('/campeonato', filmesOk)
      .then(response => {
        history.push('resultado', response.data)
      })
      .catch((error) => {
        console.error(error.response.data);
        exibeErro(error.response.data);
      });
  }

  return (
    <>
    <Banner titulo="Campeonato de Filmes" fase="Fase de Seleção" descricao="Selecione 8 filmes que você deseja que entrem na competição e depois pressione o botão Gerar Meu Campeonato para prosseguir." />
    { erro > '' &&
      <Erro>
        <strong>{erro}</strong>
      </Erro>
    }
    <DivControle>
      <p>Selecionado {totalFilmesSelecionados} de 8 filmes</p>
      { totalFilmesSelecionados == 8 && <button onClick={handleGeraCampeonato}>Gerar meu Campeonato</button>}
      { totalFilmesSelecionados != 8 && <span>Escolha 8 Filmes</span>}
    </DivControle>

    { filmes.length == 0 && <Carregando />}
    { filmes.length > 0 &&
      <Filmes>
        {filmes.map(filme => (
        <label key={filme.id}>
          <input type="checkbox" onChange={handleSelecionaFilme} value={filme.id} name={filme.id} id={filme.id}/>
          <div>
            <strong>{filme.titulo}</strong>
            <p>{filme.ano}</p>
          </div>
        </label>
        ))}
      </Filmes>
    }

    </>
  )
}

export default ListagemFilmes;
