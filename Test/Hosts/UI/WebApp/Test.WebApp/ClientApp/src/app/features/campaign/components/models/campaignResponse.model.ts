import { Campaign } from "./campaign.model";


export interface CampaignResponse {
  status: number;
  data: Campaign;
  message: string;
}
