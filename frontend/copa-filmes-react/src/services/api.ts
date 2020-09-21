import axios from 'axios';

const api = axios.create({
  baseURL: 'http://localhost:5000/v1/filmes',
});

export default api;
