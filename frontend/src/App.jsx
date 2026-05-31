import { useState } from 'react';
import { BrowserRouter, Routes, Route, Link } from 'react-router-dom';
import Dashboard from './pages/Dashboard';
import Teams from './pages/Teams';
import Initiatives from './pages/Initiatives';
import Epics from './pages/Epics';
import Persons from './pages/Persons';

const USERS = [
  { name: 'Ana', role: 'management' },
  { name: 'Dan', role: 'engineering_manager' },
  { name: 'Sara', role: 'team_lead' },
];

const NAV_BY_ROLE = {
  management:           [{ to: '/', label: 'Dashboard' }, { to: '/initiatives', label: 'Initiatives' }],
  engineering_manager:  [{ to: '/', label: 'Dashboard' }, { to: '/initiatives', label: 'Initiatives' }, { to: '/epics', label: 'Epics' }],
  team_lead:            [{ to: '/', label: 'Dashboard' }, { to: '/teams', label: 'Teams' }, { to: '/persons', label: 'Persons' }],
};

export default function App() {
  const [user, setUser] = useState(USERS[0]);
  const navLinks = NAV_BY_ROLE[user.role];

  return (
    <BrowserRouter>
      <nav style={{ padding: '1rem', borderBottom: '1px solid #ccc', display: 'flex', gap: '1rem', alignItems: 'center' }}>
        <select value={user.name} onChange={e => setUser(USERS.find(u => u.name === e.target.value))}>
          {USERS.map(u => <option key={u.name} value={u.name}>{u.name} — {u.role.replace('_', ' ')}</option>)}
        </select>
        {navLinks.map(l => <Link key={l.to} to={l.to}>{l.label}</Link>)}
      </nav>
      <main style={{ padding: '2rem' }}>
        <Routes>
          <Route path="/" element={<Dashboard />} />
          <Route path="/teams" element={<Teams />} />
          <Route path="/initiatives" element={<Initiatives />} />
          <Route path="/epics" element={<Epics />} />
          <Route path="/persons" element={<Persons />} />
        </Routes>
      </main>
    </BrowserRouter>
  );
}
