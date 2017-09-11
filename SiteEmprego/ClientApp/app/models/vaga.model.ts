export class Vaga {
    constructor(
        public vagaId?: number,
        public salario?: number,
        public titulo?: string,
        public descricao?: string,
        public cidade?: string,
        public estado?: string,
        public vagaAtiva?: string,
        public criadoEm?: string,
        public usuario?: string,
        public candidaturas?: string) { }
}