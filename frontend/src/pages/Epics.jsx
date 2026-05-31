import { useState, useEffect } from 'react';
import { epicsApi, teamsApi, initiativesApi } from '../api';


export default function Epics() {
  const [epics, setEpics] = useState([]);
  const [teams, setTeams] = useState([]);
  const [initiatives, setInitiatives] = useState([]);
  const [form, setForm] = useState({ name: '', initiativeId: '', teamId: '', estimatedDays: 10, startDate: '2025-01-01', dueDate: '2025-06-30' });

  const load = () => epicsApi.getAll().then(setEpics);

  useEffect(() => {
    load();
    teamsApi.getAll().then(setTeams);
    initiativesApi.getAll().then(setInitiatives);
  }, []);

  const create = async () => {
    await epicsApi.create({ ...form, estimatedDays: Number(form.estimatedDays) });
    load();
  };

  const remove = async (id) => {
    await epicsApi.delete(id);
    load();
  };

  return (
    <div>
      <h1>Epics</h1>
      <div style={{ display: 'flex', gap: '0.5rem', marginBottom: '1rem', flexWrap: 'wrap' }}>
        <input placeholder="Name" value={form.name} onChange={e => setForm({ ...form, name: e.target.value })} />
        <select value={form.initiativeId} onChange={e => setForm({ ...form, initiativeId: e.target.value })}>
          <option value="">Select Initiative</option>
          {initiatives.map(i => <option key={i.id} value={i.id}>{i.name}</option>)}
        </select>
        <select value={form.teamId} onChange={e => setForm({ ...form, teamId: e.target.value })}>
          <option value="">Select Team</option>
          {teams.map(t => <option key={t.id} value={t.id}>{t.name}</option>)}
        </select>
        <input type="number" placeholder="Days" value={form.estimatedDays} onChange={e => setForm({ ...form, estimatedDays: e.target.value })} style={{ width: '80px' }} />
        <input type="date" value={form.startDate} onChange={e => setForm({ ...form, startDate: e.target.value })} />
        <input type="date" value={form.dueDate} onChange={e => setForm({ ...form, dueDate: e.target.value })} />
        <button onClick={create}>Add Epic</button>
      </div>
      <table>
        <thead><tr><th>Name</th><th>Team</th><th>Estimated Days</th><th>Due Date</th><th></th></tr></thead>
        <tbody>
          {epics.map(e => (
            <tr key={e.id}>
              <td>{e.name}</td>
              <td>{teams.find(t => t.id === e.teamId)?.name ?? e.teamId}</td>
              <td>{e.estimatedDays}</td>
              <td>{new Date(e.dueDate).toLocaleDateString()}</td>
              <td><button onClick={() => remove(e.id)} style={{ background: '#dc2626' }}>Delete</button></td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
