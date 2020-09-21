import styled from 'styled-components';

export const BannerDiv = styled.div`
background: gray;
padding: 40px;
text-align: center;

h1{
  font-size: 16px;
  color: #3a3a3a;
}

h2{
  margin-top: 10px;
  font-size: 32px;
  color: white;

  &::after{
    content: "";
    display: block;
    height: 3px;
    width: 40px;
    background: #3a3a3a;
    margin: 10px auto;
  }
}

p{
  color: white;
  max-width: 600px;
  display: block;
  margin: 0 auto;
  margin-top: 20px;;
}
`;
