import { Container } from 'semantic-ui-react';
import './App.css';
import Dashboard from './layouts/Dashboard'; // module loader
import 'semantic-ui-css/semantic.min.css'
import Navi from './layouts/Navi';

function App() {
  return (
    <div className="App">
      <Navi></Navi>
      <Container className='main'>
        <Dashboard />
      </Container>
    </div>
  );
}

export default App;
