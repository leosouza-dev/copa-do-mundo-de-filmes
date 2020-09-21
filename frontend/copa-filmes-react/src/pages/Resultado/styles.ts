import styled from 'styled-components';

export const Finalista = styled.div`
  margin-top: 20px;
  align-items: center;
  display: flex;

  div:first-child{
    display: flex;
    align-items: center;
    justify-content: center;
    background: grey;
    width: 50px;
    height: 50px;
  }

  div{
    & + div{
      display: flex;
      align-items: center;
      padding-left: 30px;
      background: white;
      height: 50px;
      width: 100%;
    }
  }

`;

export const Voltar = styled.div`
  margin-top: 30px;
  text-align: center;

  a{
    text-decoration: none;
    padding: 10px;
    background: #55ff88;
    color: black;

    &:hover{
      background: #22ff55;
    }
  }
`;
