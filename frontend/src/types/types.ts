export type Bowler = {
  bowlerID: number;
  bowlerFirstName: string;
  bowlerMiddleInit: string;
  bowlerLastName: string;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: number;
  bowlerPhoneNumber: string;
  teamID: number;
  team: Team;
};

export type Team = {
  teamID: number;
  teamName: string;
};
