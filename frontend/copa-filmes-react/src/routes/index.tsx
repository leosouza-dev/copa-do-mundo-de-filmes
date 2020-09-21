import React from 'react';
import { Switch, Route } from 'react-router-dom';

import ListagemFilmes from '../pages/ListagemFilmes';
import Resultado from '../pages/Resultado';

const Routes: React.FC = () => {
  return (
    <Switch>
      <Route path="/" component={ListagemFilmes} exact />
      <Route path="/resultado" component={Resultado} />
    </Switch>
  );
};

export default Routes;
