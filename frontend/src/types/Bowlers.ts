import type { Team } from './Team';

export type Bowler = {
  bowlerId: number;
  bowlerFirstName: string;
  bowlerMiddleInit: string;
  bowlerLastName: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: number;
  bowlerPhoneNumber: string;
  teamId: number;
  team: Team;
};
