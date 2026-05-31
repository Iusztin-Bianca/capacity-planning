import { useState, useEffect } from 'react';
import { teamsApi } from '../api';

export default function Teams() {
  const [teams, setTeams] = useState([]);
  const [name, setName] = useState('');
  const [overhead, setOverhead] = useState(20);

  const load = () => teamsApi.getAll().then(setTeams);

  useEffect(() => { load(); }, []);

  const create = async () => {
    await teamsApi.create({ name, overheadPercentage: Number(overhead) });
    load();
    setName('');
  };

  const remove = async (id) => {
    await teamsApi.delete(id);
    load();
  };

  return (
    <div>
      <h1>Teams</h1>
      <div style={{ display: 'flex', gap: '0.5rem', marginBottom: '1rem' }}>
        <input placeholder="Team name" value={name} onChange={e => setName(e.target.value)} />
        <input type="number" placeholder="Overhead %" value={overhead} onChange={e => setOverhead(e.target.value)} style={{ width: '100px' }} />
        <button onClick={create}>Add Team</button>
      </div>
      <table>
        <thead><tr><th>Name</th><th>Overhead %</th><th>Members</th><th></th></tr></thead>
        <tbody>
          {teams.map(t => (
            <tr key={t.id}>
              <td>{t.name}</td>
              <td>{t.overheadPercentage}%</td>
              <td>{t.memberCount}</td>
              <td><button onClick={() => remove(t.id)} style={{ background: '#dc2626' }}>Delete</button></td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
