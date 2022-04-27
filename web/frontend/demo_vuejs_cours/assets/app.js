import { createApp } from 'vue';

const app = createApp({
    data() { // Retourne toutes les variables pour les scripts
        return {
            message: "Hello Vue!", // Affichage html ligne 20
            toto: [1,2,3,4,5],
            toto2: ""
        }
    },
    methods: { // Fonction de notre application

    },
    mounted() { // 

    }
}).mount('#app') // Où greffer notre application vuejs
