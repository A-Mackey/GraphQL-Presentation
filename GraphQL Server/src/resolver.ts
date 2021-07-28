import { gql } from 'apollo-server';
import { IResolvers } from './generated/graphql';

// Type definitions define the "shape" of your data and specify
// which ways the data can be fetched from the GraphQL server.
export const typeDefs = gql`
  # Comments in GraphQL are defined with the hash (#) symbol.

  # TODO
  # Add the number of ping pong games each intern has played
  type Intern {
    id: Int
    name: String
    age: Int
    about: String
    languages: [String]
    projects: [String]
    numberOfPingPongGamesPlayed: Int
  }

  # The "Query" type is the root of all GraphQL queries.
  # (A "Mutation" type will be covered later on.)
  type Query {
    intern(id: Int): Intern
    interns: [Intern]
  }
`;

// Resolvers define the technique for fetching the types in the
// schema.  We'll retrieve books from the "books" array above.
export const resolvers: IResolvers = {
  Query: {
    intern: (_, args, ctx) => ctx.dataSources.internProvider.getIntern(args),
    interns: (_, __, ctx) => ctx.dataSources.internProvider.getInterns()
  }
};
