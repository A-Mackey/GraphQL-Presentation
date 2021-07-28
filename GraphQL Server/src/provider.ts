import { DataSource } from 'apollo-datasource';
import fetch from 'node-fetch';
import { QueryInternArgs } from './generated/graphql';

const url = 'https://localhost:5001/Interns';

// This is a (simple) data source which can be used for retrieving
// the sample collection of books. This dataSource is injected
// into the context of the apollo server, which makes it usable
// inside the resolvers.
export class InternProvider extends DataSource {
  public async getIntern(args: QueryInternArgs) {
    const interns = await fetch(url, {
      method: 'GET'
    });

    const json = await interns.json();

    return json.interns[args.id];
  }

  public async getInterns() {
    const interns = await fetch(url, {
      method: 'GET'
    });

    const json = await interns.json();

    return json.interns;
  }
}
