export class Candidatura {
    constructor(
        public candidaturaId?: number,
        public vaga?: number,
        public usuario?: string,
        public criadaEm?: string,
        public candidaturaAtiva?: boolean) { }
}