import { Router, Request, Response } from 'express';
import fs from 'fs';
import path from 'path';

const router = Router();
const dbFilePath = path.resolve(__dirname, '../../db.json');

// Helper function to read the database
const readDatabase = () => {
  const data = fs.readFileSync(dbFilePath, 'utf8');
  return JSON.parse(data);
};

// Helper function to write to the database
const writeDatabase = (data: any) => {
  fs.writeFileSync(dbFilePath, JSON.stringify(data, null, 2));
};

// Submit a new form entry
router.post('/submit', (req: Request, res: Response) => {
  const { name, email, phone, github_link, stopwatch_time } = req.body;
  
  if (!name || !email || !phone || !github_link || !stopwatch_time) {
    return res.status(400).json({ error: 'All fields are required' });
  }

  const db = readDatabase();
  db.submissions.push({ name, email, phone, github_link, stopwatch_time });
  writeDatabase(db);

  res.status(201).json({ message: 'Submission successful' });
});

// Read a form entry by index
router.get('/read', (req: Request, res: Response) => {
  const index = parseInt(req.query.index as string, 10);

  const db = readDatabase();
  if (isNaN(index) || index < 0 || index >= db.submissions.length) {
    return res.status(404).json({ error: 'Submission not found' });
  }

  res.json(db.submissions[index]);
});

export default router;
