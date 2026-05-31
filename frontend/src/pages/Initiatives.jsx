import { useState, useEffect } from 'react';
import { initiativesApi } from '../api';

const PRIORITY = ['Low', 'Medium', 'High', 'Critical'];

export default function Initiatives() {
  const [initiatives, setInitiatives] = useState([]);
  const [name, setName] = useState('');
  const [priority, setPriority] = useState(1);
  const [targetDate, setTargetDate] = useState('2025-12-31');

  const load = () => initiativesApi.getAll().then(setInitiatives);

  useEffect(() => { load(); }, []);

  const create = async () => {
    if (!name) { alert('Name is required.'); return; }
    if (new Date(targetDate) < new Date()) { alert('Target date cannot be in the past.'); return; }
    await initiativesApi.create({ name, priority: Number(priority), targetDate });
    load();
    setName('');
  };

  const remove = async (id) => {
    await initiativesApi.delete(id);
    load();
  };

  return (
    <div>
      <h1>Initiatives</h1>
      <div style={{ display: 'flex', gap: '0.5rem', marginBottom: '1rem' }}>
        <input placeholder="Name" value={name} onChange={e => setName(e.target.value)} />
        <select value={priority} onChange={e => setPriority(e.target.value)}>
          {PRIORITY.map((p, i) => <option key={i} value={i}>{p}</option>)}
        </select>
        <input type="date" value={targetDate} onChange={e => setTargetDate(e.target.value)} />
        <button onClick={create}>Add</button>
      </div>
      <table>
        <thead><tr><th>Name</th><th>Priority</th><th>Target Date</th><th></th></tr></thead>
        <tbody>
          {initiatives.map(i => (
            <tr key={i.id}>
              <td>{i.name}</td>
              <td>{PRIORITY[i.priority]}</td>
              <td>{new Date(i.targetDate).toLocaleDateString()}</td>
              <td><button onClick={() => remove(i.id)} style={{ background: '#dc2626' }}>Delete</button></td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
