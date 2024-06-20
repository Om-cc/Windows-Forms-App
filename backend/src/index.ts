import express, { Request, Response } from 'express';
import submissionsRouter from './routes/submissions';

const app = express();
const port = 3000;

// Middleware to parse JSON bodies
app.use(express.json());

// Route for submissions
app.use('/submissions', submissionsRouter);

// Simple ping endpoint
app.get('/ping', (req: Request, res: Response) => {
  res.send(true);
});

// Start the server
app.listen(port, () => {
  console.log(`Server is running on http://localhost:${port}`);
});
