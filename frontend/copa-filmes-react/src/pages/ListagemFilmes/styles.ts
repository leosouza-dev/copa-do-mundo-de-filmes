import styled from 'styled-components';

export const Erro = styled.div`
    background: #ff5555;
    padding: 10px;
    margin-top: 20px;
`

export const DivControle = styled.div`
  display: flex;
  justify-content: space-between;
  margin-top: 40px;
  margin-bottom: 10px;

  p{
    display: block;
    max-width: 100px;
  }

  button{
    padding: 10px;
  }
  /* a{
    background: #000;
    color: white;
    text-decoration: none;
    padding: 10px;
  } */

  span{
    padding:10px;
    color: black;
    background: #ff5555;
    font-weight: bold;
  }
`;

export const Filmes = styled.form`
  display: felx;
  flex-wrap: wrap;
  justify-content: space-between;

  label{
    cursor: pointer;
    flex-basis: 220px;
    flex-grow: 1;
    padding: 20px;
    background: white;
    max-width: 500px;
    display: flex;
    align-items: center;
    margin-bottom: 5px;
    margin-right: 5px;

    /* & + label{
      margin: 5px;
    } */

    div{
      margin-left: 20px;

      p{
        margin: 0;
      }
    }

  }
`;
