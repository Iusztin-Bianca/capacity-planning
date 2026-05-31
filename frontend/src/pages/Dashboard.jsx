import { useState, useEffect } from 'react';
import { capacityApi } from '../api';

export default function Dashboard() {
  const [report, setReport] = useState(null);
  const [startDate, setStartDate] = useState('2026-01-01');
  const [endDate, setEndDate] = useState('2026-12-31');

  const load = () => capacityApi.getReport(startDate, endDate).then(setReport);

  useEffect(() => { load(); }, []);

  return (
    <div>
      <h1>Capacity Dashboard</h1>
      <div style={{ display: 'flex', gap: '1rem', marginBottom: '1rem' }}>
        <input type="date" value={startDate} onChange={e => setStartDate(e.target.value)} />
        <input type="date" value={endDate} onChange={e => setEndDate(e.target.value)} />
        <button onClick={load}>Calculate</button>
      </div>
      {report && (
        <table>
          <thead>
            <tr>
              <th>Team</th>
              <th>Net Capacity (days)</th>
              <th>Allocated (days)</th>
              <th>Utilization %</th>
              <th>Status</th>
            </tr>
          </thead>
          <tbody>
            {report.teams.map(t => (
              <tr key={t.teamId} style={{ background: t.utilizationPercentage > 100 ? '#450a0a' : t.utilizationPercentage > 80 ? '#422006' : '#052e16' }}>
                <td>{t.teamName}</td>
                <td>{t.netCapacityDays.toFixed(1)}</td>
                <td>{t.allocatedDays}</td>
                <td>{t.utilizationPercentage}%</td>
                <td>{t.utilizationPercentage > 100 ? '🔴 Over' : t.utilizationPercentage > 80 ? '🟡 At risk' : '🟢 OK'}</td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
}
