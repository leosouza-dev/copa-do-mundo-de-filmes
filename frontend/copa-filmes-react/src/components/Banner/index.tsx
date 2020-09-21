import React from 'react';

import { BannerDiv } from './styles';

interface Props {
  titulo: string;
  fase: string;
  descricao: string;
}

const Banner: React.FC<Props> = ({titulo, fase, descricao}) => {
  return (
    <BannerDiv>
      <h1>{titulo}</h1>
      <h2>{fase}</h2>
      <p>{descricao}</p>
    </BannerDiv>
  )
}

export default Banner;
