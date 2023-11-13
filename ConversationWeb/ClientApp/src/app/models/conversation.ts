export interface Conversations {
  conversations: ChatEntity;
  meta: Meta;
}

export interface ChatEntity {
  unique_name: string;
  date_updated: string;
  friendly_name: string;
  timers: Timers;
  account_sid: string;
  url: string;
  state: string;
  date_created: string;
  messaging_service_sid: string;
  sid: string;
  attributes: string;
  bindings: string;
  chat_service_sid: string;
  links: Links;
}

export interface Links {
  participants: string;
  messages: string;
  webhooks: string;
}

export interface Timers {}

export interface Meta {
  page: number;
  page_size: number;
  first_page_url: string;
  previous_page_url: any;
  url: string;
  next_page_url: any;
  key: string;
}
