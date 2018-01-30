import 'bootstrap';
import Vue from 'vue';
import axios from 'axios';
import vueRouter from 'vue-router';
import $ from 'jquery'
import VeeValidate from 'vee-validate';

axios.defaults.baseURL = $("base").first().attr("href") + 'api/';

Vue.prototype.$http = axios;
Vue.use(vueRouter);
Vue.use(VeeValidate);

new Vue({
    el: '#app-root',
    router: new vueRouter({
        mode: 'history',
        routes: [
          { path: '/', name: 'home', component: require('./components/app/app.vue') }
        ]
      }),
    render: h => h(require('./components/app/app.vue'))
});
