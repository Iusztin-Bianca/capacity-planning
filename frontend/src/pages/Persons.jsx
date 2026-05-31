import { useState, useEffect } from 'react';
import { personsApi, teamsApi } from '../api';

export default function Persons() {
  const [teams, setTeams] = useState([]);
  const [selectedTeam, setSelectedTeam] = useState('');
  const [persons, setPersons] = useState([]);
  const [form, setForm] = useState({ name: '', role: '', availabilityPercentage: 100 });

  useEffect(() => { teamsApi.getAll().then(setTeams); }, []);

  const loadPersons = (teamId) => {
    setSelectedTeam(teamId);
    personsApi.getByTeam(teamId).then(setPersons);
  };

  const create = async () => {
    await personsApi.create({ ...form, teamId: selectedTeam, availabilityPercentage: Number(form.availabilityPercentage) });
    personsApi.getByTeam(selectedTeam).then(setPersons);
    setForm({ name: '', role: '', availabilityPercentage: 100 });
  };

  const remove = async (id) => {
    await personsApi.delete(id);
    personsApi.getByTeam(selectedTeam).then(setPersons);
  };

  return (
    <div>
      <h1>Team Members</h1>
      <div style={{ marginBottom: '1rem' }}>
        <select value={selectedTeam} onChange={e => loadPersons(e.target.value)}>
          <option value="">Select Team</option>
          {teams.map(t => <option key={t.id} value={t.id}>{t.name}</option>)}
        </select>
      </div>
      {selectedTeam && (
        <>
          <div style={{ display: 'flex', gap: '0.5rem', marginBottom: '1rem' }}>
            <input placeholder="Name" value={form.name} onChange={e => setForm({ ...form, name: e.target.value })} />
            <input placeholder="Role" value={form.role} onChange={e => setForm({ ...form, role: e.target.value })} />
            <input type="number" placeholder="Availability %" value={form.availabilityPercentage} onChange={e => setForm({ ...form, availabilityPercentage: e.target.value })} style={{ width: '120px' }} />
            <button onClick={create}>Add Member</button>
          </div>
          <table>
            <thead><tr><th>Name</th><th>Role</th><th>Availability %</th><th></th></tr></thead>
            <tbody>
              {persons.map(p => (
                <tr key={p.id}>
                  <td>{p.name}</td>
                  <td>{p.role}</td>
                  <td>{p.availabilityPercentage}%</td>
                  <td><button onClick={() => remove(p.id)} style={{ background: '#dc2626' }}>Delete</button></td>
                </tr>
              ))}
            </tbody>
          </table>
        </>
      )}
    </div>
  );
}
