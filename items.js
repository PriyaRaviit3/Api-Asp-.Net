new Vue({
  <script>

  export default{
    data(){
      return{

      }
    },
    methods:{

    },
    created(){
      this.$http.get('https://itemdemoapplication.azurewebsites.net/api/items'){
        console.log(data);
      }
    }

    }
