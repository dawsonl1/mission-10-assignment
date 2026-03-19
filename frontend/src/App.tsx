import { useEffect, useState } from 'react';
import './App.css';
import type { Bowler } from './types/types.ts';
import Heading from './components/Heading';
import BowlerTable from './components/BowlerTable/BowlerTable';

function App() {
  const [bowlers, setBowlers] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchBowlers = async () => {
      const response = await fetch('http://localhost:5074/api/Bowlers');
      const bowlersList: Bowler[] = await response.json();
      setBowlers(bowlersList);
    };
    fetchBowlers();
  }, []);

  return (
    <>
      <Heading />
      <BowlerTable bowlers={bowlers} />
    </>
  );
}

export default App;
